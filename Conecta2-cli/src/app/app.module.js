"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var platform_browser_1 = require("@angular/platform-browser");
var core_1 = require("@angular/core");
var animations_1 = require("@angular/platform-browser/animations");
var app_routing_module_1 = require("./app-routing.module");
var http_1 = require("@angular/http");
var app_component_1 = require("./app.component");
var tabs_1 = require("@angular/material/tabs");
var card_1 = require("@angular/material/card");
var icon_1 = require("@angular/material/icon");
var list_1 = require("@angular/material/list");
var grid_list_1 = require("@angular/material/grid-list");
var button_1 = require("@angular/material/button");
var home_component_1 = require("./components/home/home.component");
var monitoreo_component_1 = require("./components/home/monitoreo/monitoreo.component");
var core_2 = require("@agm/core");
var chat_component_1 = require("./components/chat/chat.component");
var nuevocaso_component_1 = require("./components/nuevocaso/nuevocaso.component");
var material_1 = require("@angular/material");
var stepper_1 = require("@angular/material/stepper");
var common_1 = require("@angular/common");
var chat_service_1 = require("./services/chat.service");
var input_1 = require("@angular/material/input");
var select_1 = require("@angular/material/select");
var amazing_time_picker_1 = require("amazing-time-picker");
var datepicker_1 = require("@angular/material/datepicker");
var forms_1 = require("@angular/forms");
var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        core_1.NgModule({
            declarations: [
                app_component_1.AppComponent,
                home_component_1.HomeComponent,
                monitoreo_component_1.MonitoreoComponent,
                chat_component_1.ChatComponent,
                nuevocaso_component_1.NuevocasoComponent
            ], entryComponents: [nuevocaso_component_1.NuevocasoComponent],
            imports: [
                platform_browser_1.BrowserModule,
                forms_1.FormsModule,
                app_routing_module_1.AppRoutingModule,
                animations_1.BrowserAnimationsModule,
                forms_1.FormsModule,
                forms_1.ReactiveFormsModule,
                input_1.MatInputModule,
                tabs_1.MatTabsModule,
                card_1.MatCardModule,
                icon_1.MatIconModule,
                button_1.MatButtonModule,
                material_1.MatDialogModule,
                stepper_1.MatStepperModule,
                grid_list_1.MatGridListModule,
                list_1.MatListModule,
                common_1.CommonModule,
                select_1.MatSelectModule,
                amazing_time_picker_1.AmazingTimePickerModule,
                datepicker_1.MatDatepickerModule,
                material_1.MatNativeDateModule,
                http_1.HttpModule,
                core_2.AgmCoreModule.forRoot({
                    apiKey: 'AIzaSyD6l0Wq6cXBaDqF7I03FxvG-6-Py0Ib0F4',
                    libraries: ['places']
                }),
            ],
            providers: [
                chat_service_1.ChatService
            ],
            bootstrap: [app_component_1.AppComponent]
        })
    ], AppModule);
    return AppModule;
}());
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map