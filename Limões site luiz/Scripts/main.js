// Array para armazenar os itens selecionados
let itensSelecionados = [];

// Função para adicionar um item ao carrinho
function adicionarOpcao(nomeProduto, idImagem) {
const quantidadeInput = document.getElementById(`quantidade_${nomeProduto}`);
const precoInput = document.getElementById(`preco_${nomeProduto}`);

const quantidade = parseInt(quantidadeInput.value);
const preco = parseFloat(precoInput.value);

if (quantidade > 0) {
const item = {
nome: idImagem, // Usando o ID da imagem como o nome do produto
quantidade: quantidade,
preco: preco
};

// Verifica se o item já existe na lista
const index = itensSelecionados.findIndex(i => i.nome === item.nome);
if (index > -1) {
// Atualiza a quantidade do item existente
itensSelecionados[index].quantidade += item.quantidade;
} else {
// Adiciona um novo item à lista
itensSelecionados.push(item);
}

// Salva o array atualizado no localStorage
localStorage.setItem('itensSelecionados', JSON.stringify(itensSelecionados));

renderizarTabela();
}
}

// Função para renderizar a tabela com os itens selecionados
function renderizarTabela() {
const corpoTabela = document.getElementById("corpoTabela");
corpoTabela.innerHTML = "";

let total = 0;

itensSelecionados.forEach(item => {
const precoTotal = item.quantidade * item.preco;
total += precoTotal;

const linha = document.createElement("tr");
linha.innerHTML = `
<td>${item.nome}</td>
<td>${item.quantidade}</td>
<td>R$ ${precoTotal.toFixed(2)}</td>
`;
corpoTabela.appendChild(linha);
});

// Adiciona a linha com o total
const linhaTotal = document.createElement("tr");
linhaTotal.innerHTML = `
<td colspan="2">Total</td>
<td>R$ ${total.toFixed(2)}</td>
`;
corpoTabela.appendChild(linhaTotal);
}

// Recupera os itens selecionados do localStorage ao carregar a página
window.onload = function() {
const storedItems = localStorage.getItem('itensSelecionados');cciptantesdefecha
if (storedItems) {
itensSelecionados = JSON.parse(storedItems);
renderizarTabela();
}
};