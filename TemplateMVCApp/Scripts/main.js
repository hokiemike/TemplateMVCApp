// main .js
var ExampleViewModel = function () {
    var self = this;

    self.jsFrameworks = ko.observableArray([
        'High Priority',
        'Future Release',
        'Cosmetic Enhancement',
        'Chris Rauber',
        'Jason Butler'
    ]);

    self.frameworkToAdd = ko.observable("");
    self.addFramework = function () {
        self.jsFrameworks.push(self.frameworkToAdd());
    };

    self.removeFramework = function (framework) {
        self.jsFrameworks.remove(framework);
    };

};


var viewModel = new ExampleViewModel();
ko.applyBindings(viewModel);