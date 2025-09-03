(function() {
  'use strict';

  const container = document.getElementById('pokemon-container');
  const searchInput = document.getElementById('search');
  const loadMoreBtn = document.getElementById('load-more');
  const clearBtn = document.getElementById('clear-search');
  const themeToggle = document.getElementById('theme-toggle');
  const typeFilter = document.getElementById('type-filter');
  const sortOrder = document.getElementById('sort-order');

  if (!container || !searchInput || !loadMoreBtn) return;

  const typeColors = {
    normal: "#A8A77A", fire: "#EE8130", water: "#6390F0",
    electric: "#F7D02C", grass: "#7AC74C", ice: "#96D9D6",
    fighting: "#C22E28", poison: "#A33EA1", ground: "#E2BF65",
    flying: "#A98FF3", psychic: "#F95587", bug: "#A6B91A",
    rock: "#B6A136", ghost: "#735797", dragon: "#6F35FC",
    dark: "#705746", steel: "#B7B7CE", fairy: "#D685AD"
  };

  const placeholder = 'data:image/svg+xml;utf8,'+encodeURIComponent(
    '<svg xmlns="http://www.w3.org/2000/svg" width="200" height="200"><rect width="100%" height="100%" fill="#eee"/></svg>'
  );

  let offset = 1, limit = 9;
  let allPokemons = [];

  async function fetchPokemon(nameOrId) {
    try {
      const res = await fetch('https://pokeapi.co/api/v2/pokemon/'+encodeURIComponent(nameOrId));
      if (!res.ok) return null;
      return await res.json();
    } catch (err) { console.error(err); return null; }
  }

  async function fetchPokemonSpecies(nameOrId) {
    try {
      const res = await fetch('https://pokeapi.co/api/v2/pokemon-species/'+encodeURIComponent(nameOrId));
      if (!res.ok) return null;
      return await res.json();
    } catch (err) { console.error(err); return null; }
  }

  function textColorForBg(hex) {
    if (!hex || hex[0] !== '#') return '#222';
    hex = hex.replace('#','');
    if (hex.length===3) hex = hex.split('').map(c=>c+c).join('');
    const r=parseInt(hex.substring(0,2),16);
    const g=parseInt(hex.substring(2,4),16);
    const b=parseInt(hex.substring(4,6),16);
    const luminance = 0.299*r + 0.587*g + 0.114*b;
    return luminance>180 ? '#222':'#fff';
  }

  function createCard(pokemon) {
    if (!pokemon) return;
    const card = document.createElement('div'); card.className='card';

    const primary = pokemon.types[0].type.name;
    const secondary = pokemon.types[1]?.type.name;

    const bg = secondary 
      ? `linear-gradient(135deg, ${typeColors[primary]}, ${typeColors[secondary]})`
      : typeColors[primary];

    card.style.background = bg;
    card.style.color = textColorForBg(typeColors[primary]);

    const image = pokemon.sprites?.other?.['official-artwork']?.front_default
                  ?? pokemon.sprites?.front_default
                  ?? placeholder;

    const nameCap = pokemon.name.charAt(0).toUpperCase() + pokemon.name.slice(1);

    card.innerHTML = `<div class="card-top"><img src="${image}" alt="${nameCap}" loading="lazy"></div>
                      <div class="card-body"><h3>${nameCap}</h3></div>`;

    card.addEventListener('click', () => showOverlay(pokemon));

    container.appendChild(card);
  }

  function displayPokemons(list) {
    container.innerHTML = '';
    const type = typeFilter.value;
    let filtered = type ? list.filter(p => p.types.some(t => t.type.name === type)) : list;

    const order = sortOrder.value;
    filtered.sort((a,b)=>{
      if(order==='id-asc') return a.id-b.id;
      if(order==='id-desc') return b.id-a.id;
      if(order==='name-asc') return a.name.localeCompare(b.name);
      if(order==='name-desc') return b.name.localeCompare(a.name);
    });

    if(filtered.length===0) container.innerHTML='<p class="msg">Nenhum Pokémon encontrado!</p>';
    filtered.forEach(p=>createCard(p));
  }

  async function loadPokemonsBatch(start,end) {
    for(let i=start;i<end;i++){
      const p = await fetchPokemon(i);
      if(p) allPokemons.push(p);
    }
    displayPokemons(allPokemons);
  }

  async function loadPokemons() {
    loadMoreBtn.disabled = true; loadMoreBtn.textContent='Carregando...';
    await loadPokemonsBatch(offset, offset+limit);
    offset += limit;
    loadMoreBtn.disabled = false; loadMoreBtn.textContent='Carregar Mais';
  }

  searchInput.addEventListener('keydown', async e => {
    if(e.key!=='Enter') return;
    const q = searchInput.value.trim().toLowerCase();
    if(!q){ container.innerHTML=''; displayPokemons(allPokemons); return; }
    container.innerHTML='<p class="msg">Buscando...</p>';
    loadMoreBtn.style.display='none';
    const pokemon = await fetchPokemon(q);
    container.innerHTML='';
    if(pokemon){ createCard(pokemon); } else { container.innerHTML='<p class="msg">Pokémon não encontrado!</p>'; loadMoreBtn.style.display='inline-block'; }
  });

  clearBtn.addEventListener('click', ()=>{ searchInput.value=''; container.innerHTML=''; loadMoreBtn.style.display='inline-block'; displayPokemons(allPokemons); });
  typeFilter.addEventListener('change', ()=>displayPokemons(allPokemons));
  sortOrder.addEventListener('change', ()=>displayPokemons(allPokemons));
  loadMoreBtn.addEventListener('click', loadPokemons);

  themeToggle.addEventListener('click', ()=>{
    if(document.body.dataset.theme==='dark'){ document.body.dataset.theme=''; themeToggle.textContent='🌙'; }
    else { document.body.dataset.theme='dark'; themeToggle.textContent='☀️'; }
  });

  loadPokemons();

  // ================= Overlay Pokémon épico =================
  async function showOverlay(pokemon) {
    const species = await fetchPokemonSpecies(pokemon.id);
    const rarity = species?.is_legendary ? 'Lendário' : species?.is_mythical ? 'Mítico' : 'Comum';
    const desc = species?.flavor_text_entries?.find(e => e.language.name==='en')?.flavor_text.replace(/\n|\f/g,' ') ?? 'Descrição não disponível.';

    const overlay = document.createElement('div');
    overlay.className='pokemon-overlay';
    overlay.dataset.type = pokemon.types[0].type.name;

    overlay.innerHTML = `
      <div class="overlay-content">
        <button class="close-btn">✕</button>
        <div class="overlay-left">
          <img src="${pokemon.sprites.other['official-artwork'].front_default}" alt="${pokemon.name}">
        </div>
        <div class="overlay-right">
          <h2>${pokemon.name.charAt(0).toUpperCase() + pokemon.name.slice(1)}</h2>
          <p><strong>Raridade:</strong> ${rarity}</p>
          <p><strong>Tipo:</strong> ${pokemon.types.map(t=>t.type.name).join(', ')}</p>
          <p class="desc">${desc}</p>
        </div>
      </div>
    `;

    document.body.appendChild(overlay);

    const primaryColor = typeColors[pokemon.types[0].type.name] || '#fff';
    const content = overlay.querySelector('.overlay-content');
    content.style.background = primaryColor;
    content.style.color = textColorForBg(primaryColor);

    // Efeito especial para Pokémon Mítico
    if (species?.is_mythical) {
      content.classList.add('mythical-glow');
      createConfettiEffect(overlay);
    }

    // Fechar overlay
    overlay.querySelector('.close-btn').addEventListener('click', () => overlay.remove());
    overlay.addEventListener('click', e => { if(e.target === overlay) overlay.remove(); });
  }

  function createConfettiEffect(overlay) {
    for (let i = 0; i < 30; i++) {
      const confetti = document.createElement('div');
      confetti.className = 'confetti-piece';
      confetti.style.left = Math.random() * 90 + '%';
      confetti.style.animationDelay = (Math.random() * 2) + 's';
      overlay.appendChild(confetti);
    }
  }

})();
