function Emailer(){
    this.resultCallback = null;
}

Emailer.prototype.showEmailer = function (toRecipients, body, subject) {
    var args = {};
    if (toRecipients)
        args.toRecipients = toRecipients;

    if (body)
        args.body = body;

    if (subject)
        args.subject = subject;

    Cordova.exec(null, null, "SendEmail", "send", args);
}

Emailer.install = function () {
    console.log("install started");

    if (!window.plugins)
        window.plugins = {};

    if (!window.plugins.myEmailer) 
        window.plugins.myEmailer = new Emailer();    
}

Cordova.addConstructor(Emailer.install);