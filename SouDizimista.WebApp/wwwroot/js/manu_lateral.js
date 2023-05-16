var list = document.querySelectorAll('.list');

function ActiveLink() {
    list.forEach((item) =>
        item.classList.remove('active'));
    this.classList.add('active');

}

list.forEach((item) =>
    item.addEventListener('click', ActiveLink)
);

let menuList = document.querySelectorAll('#paroquias-menu');


menuList.forEach((item) =>
    item.addEventListener('click', showMenuLateral)    
);

function showMenuLateral() {
    menuList.forEach((item) =>
        document.querySelector('.navigation').style.display = 'block');
}
