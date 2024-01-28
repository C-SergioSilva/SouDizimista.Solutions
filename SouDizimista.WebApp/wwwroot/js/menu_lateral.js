//$(document).ready(function (e) {

//    e.preventDefault(); 
//    var moduleName = $(this).data('module');

//    $(".obterDados").click(function () {

//        $.ajax({
//            url: "/Home/Cadastro",
//            type: "POST",
//            dataType: "html",
//            success: function (data) {
//                $('#navigator').html(data);
//            },
//            erro: function (error) {

//            }
//        });

//    });
//});




var list = document.querySelectorAll('.list');

function ActiveLink() {
    list.forEach((item) =>
        item.classList.remove('active'));
    this.classList.add('active');

}

list.forEach((item) =>
    item.addEventListener('click', ActiveLink)
);

let menuList = document.querySelectorAll('#modulo-menu');


menuList.forEach((item) =>
    item.addEventListener('click', showMenuLateral)    
);

function showMenuLateral() {
    menuList.forEach((item) =>
        document.querySelector('.navigation').style.display = 'block');
}
