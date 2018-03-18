"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var forms_1 = require("@angular/forms");
var NuevocasoComponent = /** @class */ (function () {
    function NuevocasoComponent(_formBuilder) {
        this._formBuilder = _formBuilder;
        this.date = new forms_1.FormControl(new Date());
    }
    NuevocasoComponent.prototype.ngOnInit = function () {
        this.firstFormGroup = this._formBuilder.group({
            tipoIncidente: ['', forms_1.Validators.required],
            horaIncidente: ['', forms_1.Validators.required]
        });
        this.secondFormGroup = this._formBuilder.group({
            secondCtrl: ['', forms_1.Validators.required]
        });
        var horaActual = this.obtenerHoraActual();
        var fechaActual = this.obtenerFechaActual();
        this.firstFormGroup.patchValue({
            horaIncidente: horaActual
        });
    };
    NuevocasoComponent.prototype.obtenerHoraActual = function () {
        var currentdate = new Date();
        var time = currentdate.getHours() + ':' + currentdate.getMinutes();
        return time;
    };
    NuevocasoComponent.prototype.obtenerFechaActual = function () {
        var currentdate = new Date();
        var date = (currentdate.getMonth() + 1) + '/'
            + currentdate.getDate() + '/'
            + currentdate.getFullYear();
        return date;
    };
    NuevocasoComponent = __decorate([
        core_1.Component({
            selector: 'app-nuevocaso',
            templateUrl: './nuevocaso.component.html',
            styleUrls: ['./nuevocaso.component.css']
        })
    ], NuevocasoComponent);
    return NuevocasoComponent;
}());
exports.NuevocasoComponent = NuevocasoComponent;
//# sourceMappingURL=nuevocaso.component.js.map