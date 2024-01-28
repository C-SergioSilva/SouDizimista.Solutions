
// Aplicando Mascára em um campo Cep

function mascaraCep(cep) {
    cep.value = cep.value.replace(/\D/g, ''); // Remove todos os caracteres não numéricos

    if (cep.value.length === 8) {
        cep.value = cep.value.replace(/(\d{5})(\d{3})/, '$1-$2'); // Adiciona o traço após o quinto dígito
    }
}