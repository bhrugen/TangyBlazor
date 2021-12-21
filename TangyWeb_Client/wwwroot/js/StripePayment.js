redirectToCheckout = function (sessionId) {
    var stripe = Stripe("pk_test_51JcFLuLzMgCIgSRrMw19EzJALAjYC6j5mooETO1VrDWRziVUKPLyBS5nY4siaaxnTgxWg69QZIQNpUBl06WECbzB00gG4hqVX5");
    stripe.redirectToCheckout({ sessionId: sessionId });
}