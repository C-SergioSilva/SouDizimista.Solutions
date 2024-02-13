$(document).ready(function () {
    $('#icone-suspenso').click(function () {
        loadMenuSuspenso();
    });

    // Função para carregar os  menu
    function loadMenuSuspenso() {
        $.ajax({
            url: '/Menu/GetMenuSuspenso', // Rota para a ação que obtém os itens de menu
            type: 'GET',
            success: function (response) {

                // Atualizar o menu lateral com os itens de menu obtidos
                $('.menu-suspenso-navigation ul').html(response);
                document.querySelector('.menu-nav').style.display = 'block';
            },
            error: function (error) {
                console.log(error);
            }
        });
    }

});