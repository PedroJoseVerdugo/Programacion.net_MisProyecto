$(document).ready(function() {
    $('#convertBtn').click(function() {
        var amount = $('#amount').val();
        var fromCurrency = $('#fromCurrency').val();
        var toCurrency = $('#toCurrency').val();
        var apiKey = 'TU_CLAVE_API';  // Reemplaza con tu clave API

        if (amount === '' || isNaN(amount)) {
            alert('Por favor, ingrese una cantidad válida.');
            return;
        }

        $('#loading').show();
        $.ajax({
            url: `https://v6.exchangerate-api.com/v6/${apiKey}/pair/${fromCurrency}/${toCurrency}/${amount}`,
            type: 'GET',
            success: function(response) {
                if (response.result === 'success') {
                    $('#resultText').text(`${amount} ${fromCurrency} = ${response.conversion_result} ${toCurrency}`);
                } else {
                    alert('Error al obtener la tasa de cambio. Por favor, intente de nuevo.');
                }
                $('#loading').hide();
            },
            error: function() {
                alert('Error al conectar con la API de tasas de cambio.');
                $('#loading').hide();
            }
        });
    });
});
