const container = document.getElementById("pokemon-container");
const searchInput = document.getElementById("search");

// cria o botão "Carregar Mais"
const loadMoreBtn = document.createElement("button");
loadMoreBtn.textContent = "Carregar Mais";
loadMoreBtn.classList.add("load-more");
document.body.appendChild(loadMoreBtn);

// 🎨 Cores por tipo
const typeColors = {
  normal: "#A8A77A",
  fire: "#EE8130",
  water: "#6390F0",
  electric: "#F7D02C",
  grass: "#7AC74C",
  ice: "#96D9D6",
  fighting: "#C22E28",
  poison: "#A33EA1",
  ground: "#E2BF65",
  flying: "#A98FF3",
  psychic: "#F95587",
  bug: "#A6B91A",
  rock: "#B6A136",
  ghost: "#735797",
  dragon: "#6F35FC",
  dark: "#705746",
  steel: "#B7B7CE",
  fairy: "#D685AD"
};

// controle de quantos pokémon já foram carregados
let offset = 1;
const limit = 9;

// 🔍 Função para buscar Pokémon
async function fetchPokemon(nameOrId) {
  try {
    const res = await fetch(`https://pokeapi.co/api/v2/pokemon/${nameOrId}`);
    if (!res.ok) return null;
    return await res.json();
  } catch (error) {
    console.error("Erro ao buscar Pokémon:", error);
    return null;
  }
}

// 🃏 Função para criar card
function createCard(pokemon) {
  const card = document.createElement("div");
  card.classList.add("card");

  const type = pokemon.types[0].type.name;
  card.style.background = typeColors[type] || "#fff";
  card.style.color = "#fff";

  const image =
    pokemon.sprites.other["official-artwork"].front_default ||
    pokemon.sprites.front_default;

  card.innerHTML = `
    <img src="${image}" alt="${pokemon.name}">
    <h3>${pokemon.name.charAt(0).toUpperCase() + pokemon.name.slice(1)}</h3>
    <p>Tipo: ${pokemon.types.map(t => t.type.name).join(", ")}</p>
  `;

  container.appendChild(card);
}

// 🚀 Carregar Pokémon em lotes
async function loadPokemons() {
  for (let i = offset; i < offset + limit; i++) {
    const pokemon = await fetchPokemon(i);
    if (pokemon) createCard(pokemon);
  }
  offset += limit;
}

// 🔎 Buscar Pokémon digitado
searchInput.addEventListener("keypress", async (e) => {
  if (e.key === "Enter") {
    const query = searchInput.value.trim().toLowerCase();
    if (!query) return;
    container.innerHTML = "";
    const pokemon = await fetchPokemon(query);
    if (pokemon) {
      createCard(pokemon);
    } else {
      container.innerHTML = "<p>Pokémon não encontrado!</p>";
    }
  }
});

// evento do botão carregar mais
loadMoreBtn.addEventListener("click", loadPokemons);

// inicia com os 9 primeiros
loadPokemons();
