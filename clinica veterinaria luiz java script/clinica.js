// MOCK DATA
const animais = [
  { id: "1", nome: "Nino", data_de_nascimento: "15-09-2020", raca: "Birmânia", createdAt: new Date() },
  { id: "2", nome: "Rex", data_de_nascimento: "10-05-2021", raca: "Maine Coon", createdAt: new Date() },
  { id: "3", nome: "Luna", data_de_nascimento: "14-07-2020", raca: "Siamês", createdAt: new Date() },
  { id: "4", nome: "Aurora", data_de_nascimento: "03-08-2021", raca: "Siberiano", createdAt: new Date() },
  { id: "5", nome: "Mel", data_de_nascimento: "02-12-2019", raca: "Bombaim", createdAt: new Date() },
];

const usuarios = [
  {
    id: "1",
    nome: "Lucas Miguel Santos",
    email: "lucasmiguelsantos@email.com",
    senha: "86032",
    data_de_nascimento: "10-03-1999",
    animal: animais[0],
    createdAt: new Date(),
  },
  {
    id: "2",
    nome: "Marcos Oliveira da Silva",
    email: "marcosoliveiradasilva@email.com",
    senha: "25868",
    data_de_nascimento: "24-08-1997",
    animal: animais[1],
    createdAt: new Date(),
  },
];

const doutores = [
  {
    id: "1",
    nome: "Dra. Maria",
    email: "maria@vet.com",
    senha: "abcd",
    createdAt: new Date(),
  },
];

const consultorios = [
  {
    id: "1",
    usuario: usuarios[0],
    animal: animais[0],
    doutor: doutores[0],
    descricao: "Vacina anual aplicada",
    createdAt: new Date(),
  },
];

// ANIMAL
function getAnimal(id) {
  return animais.find((a) => a.id === id);
}

function getAllAnimais() {
  return animais;
}

function postAnimal(animal) {
  animais.push(animal);
  return animal;
}

function putAnimal(id, novoAnimal) {
  const index = animais.findIndex((a) => a.id === id);
  if (index !== -1) {
    animais[index] = { ...animais[index], ...novoAnimal };
    return animais[index];
  }
}

function deleteAnimal(id) {
  const index = animais.findIndex((a) => a.id === id);
  if (index !== -1) {
    return animais.splice(index, 1)[0];
  }
}

// USUARIO
function getUsuario(id) {
  return usuarios.find((u) => u.id === id);
}

function getAllUsuarios() {
  return usuarios;
}

function postUsuario(usuario) {
  usuarios.push(usuario);
  return usuario;
}

// CONSULTORIO
function getConsultorio(id) {
  return consultorios.find((c) => c.id === id);
}

function getAllConsultorios() {
  return consultorios;
}

function postConsultorio(consultorio) {
  consultorios.push(consultorio);
  return consultorio;
}

function putConsultorio(id, novoConsultorio) {
  const index = consultorios.findIndex((c) => c.id === id);
  if (index !== -1) {
    consultorios[index] = { ...consultorios[index], ...novoConsultorio };
    return consultorios[index];
  }
}

function deleteConsultorio(id) {
  const index = consultorios.findIndex((c) => c.id === id);
  if (index !== -1) {
    return consultorios.splice(index, 1)[0];
  }
}

// DOUTOR
function getDoutor(id) {
  return doutores.find((d) => d.id === id);
}

function getAllDoutores() {
  return doutores;
}

function postDoutor(doutor) {
  doutores.push(doutor);
  return doutor;
}

function putDoutor(id, novoDoutor) {
  const index = doutores.findIndex((d) => d.id === id);
  if (index !== -1) {
    doutores[index] = { ...doutores[index], ...novoDoutor };
    return doutores[index];
  }
}

function deleteDoutor(id) {
  const index = doutores.findIndex((d) => d.id === id);
  if (index !== -1) {
    return doutores.splice(index, 1)[0];
  }
}

// FUNCIONAMENTO 
console.log(getAllAnimais());             
console.log(getUsuario("1"));             
console.log(postAnimal({                  
  id: "6",
  nome: "Bolt",
  data_de_nascimento: "01-01-2022",
  raca: "Persa",
  createdAt: new Date(),
}));



