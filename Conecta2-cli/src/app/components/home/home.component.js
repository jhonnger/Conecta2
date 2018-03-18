"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var nuevocaso_component_1 = require("../nuevocaso/nuevocaso.component");
var HomeComponent = /** @class */ (function () {
    function HomeComponent(dialog) {
        this.dialog = dialog;
        this.lat = 40.7786232;
        this.lng = -74.0007019;
    }
    HomeComponent.prototype.openDialog = function () {
        var dialogRef = this.dialog.open(nuevocaso_component_1.NuevocasoComponent, {
            width: '650px',
            disableClose: true,
            data: {}
        });
        dialogRef.afterClosed().subscribe(function (result) {
            console.log('The dialog was closed');
        });
    };
    HomeComponent.prototype.ngOnInit = function () {
        // algo.triggerResize(true);
    };
    HomeComponent.prototype.cambio = function (event) {
        switch (event.index) {
            case 0:
                this.mapMonitoreo.triggerResize(true);
                break;
            case 1:
                this.mapUnidades.triggerResize(true);
                break;
        }
    };
    __decorate([
        core_1.ViewChild('mapMonitoreo')
    ], HomeComponent.prototype, "mapMonitoreo", void 0);
    __decorate([
        core_1.ViewChild('mapUnidades')
    ], HomeComponent.prototype, "mapUnidades", void 0);
    HomeComponent = __decorate([
        core_1.Component({
            selector: 'app-home',
            templateUrl: './home.component.html',
            styleUrls: ['./home.component.css']
        })
    ], HomeComponent);
    return HomeComponent;
}());
exports.HomeComponent = HomeComponent;
//# sourceMappingURL=home.component.js.map