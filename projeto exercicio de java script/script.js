const themeToggleBtn = document.getElementById('theme-toggle')
const body = document.body;
themeToggleBtn.addEventListener('click', function() {

body.classList.toggle('dark-theme');

if(body.classList.contains('dark-theme')) {
    themeToggleBtn.textContent = 'Mudar para Tema Claro';
} else {
    themeToggleBtn.textContent = 'Mudar para Tema Escuro';
}
});