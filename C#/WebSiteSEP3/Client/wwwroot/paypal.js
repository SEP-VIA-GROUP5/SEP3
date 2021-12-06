window.LoadButtonPaypal = function(value,username,gameName){
    // Render the PayPal button into #paypal-button-container
    paypal.Buttons({
        style: {
            layout: 'vertical',
            color: 'gold',
        },

        // Set up the transaction
        createOrder: function (data, actions) {
            return actions.order.create({
                purchase_units: [{
                    amount: {
                        value: value
                    }
                }]
            });
        },

        // Finalize the transaction
        onApprove: function (data, actions) {
            return actions.order.capture().then(function (orderData) {
                console.log('Capture result', orderData, JSON.stringify(orderData, null, 2));
                var transaction = orderData.purchase_units[0].payments.captures[0];
                alert('Transaction ' + transaction.status + ': ' + transaction.id + '\n\nSee console for all available details');
                if(gameName != null)
                {
                    location.href = '/ReceiptOneGame/' + username + '/' + gameName + '/' + transaction.id;
                }
                else {
                    location.href = '/ReceiptMultipleGames/' + username + '/' + transaction.id;
                }
            });
        }


    }).render('#paypal-button-container');
};