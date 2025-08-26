let mock = {};

function getAll() {
    return mock
}

function getById(Id) {
    return mock.filter((item) => item.id === id);
}

function post(item) {
  mock.push(item);
}

function update(id, newItem) {
   mock = mock.map((item) => item.id == id ? newItem : item)
}

function deLet(id) {
    mock = mock.filter((item) => item.id !== id);
}