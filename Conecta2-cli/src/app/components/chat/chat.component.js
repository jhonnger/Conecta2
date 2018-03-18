"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var ChatComponent = /** @class */ (function () {
    function ChatComponent(chatService) {
        this.chatService = chatService;
        // tslint:disable-next-line:no-inferrable-types
        this.tam_chat = 530;
        // tslint:disable-next-line:no-inferrable-types
        this.flagChat = true;
        this.contactos = [];
        this.mensajes = [
            {
                'usuario': 'Jhon',
                'bandera': true,
                'conversacion': [
                    {
                        'user': 'tu',
                        'text': 'hola!!',
                        'hora': '14:00'
                    },
                    {
                        'user': 'Jhon',
                        'text': 'hola que tal!!',
                        'hora': '14:03'
                    }
                ],
                'ultimo_mensaje': {
                    'text': 'hola que tal!!',
                    'hora': '14:03'
                }
            },
            {
                'usuario': 'Jose',
                'bandera': true,
                'conversacion': [
                    {
                        'user': 'tu',
                        'text': 'hola!!',
                        'hora': '14:00'
                    },
                    {
                        'user': 'Jose',
                        'text': 'Constesta el telefono',
                        'hora': '14:03'
                    }
                ],
                'ultimo_mensaje': {
                    'text': 'Constesta el telefono',
                    'hora': '14:03'
                }
            },
            {
                'usuario': 'Luis',
                'bandera': true,
                'conversacion': [
                    {
                        'user': 'tu',
                        'text': 'hola!!',
                        'hora': '14:00'
                    },
                    {
                        'user': 'Luis',
                        'text': 'La reunion es el sabado',
                        'hora': '14:03'
                    }
                ],
                'ultimo_mensaje': {
                    'text': 'La reunion es el sabado',
                    'hora': '14:03'
                }
            },
            {
                'usuario': 'Johhny',
                'bandera': true,
                'conversacion': [
                    {
                        'user': 'tu',
                        'text': 'hola!!',
                        'hora': '14:00'
                    },
                    {
                        'user': 'Johhny',
                        'text': 'Yara mano que fue!!',
                        'hora': '14:03'
                    }
                ],
                'ultimo_mensaje': {
                    'text': 'Yara mano que fue!!',
                    'hora': '14:03'
                }
            },
            {
                'usuario': 'Rebeca',
                'bandera': true,
                'conversacion': [
                    {
                        'user': 'tu',
                        'text': 'hola!!',
                        'hora': '14:00'
                    },
                    {
                        'user': 'Rebeca',
                        'text': 'Luis dio positivo',
                        'hora': '14:03'
                    }
                ],
                'ultimo_mensaje': {
                    'text': 'Luis dio positivo',
                    'hora': '14:03'
                }
            }
        ];
        this.chats = [
            {
                'usuario': 'Jhon',
                'bandera': true,
                'conversacion': [
                    {
                        'user': 'tu',
                        'text': 'hola!!',
                        'hora': '14:00'
                    },
                    {
                        'user': 'Jhon',
                        'text': 'hola que tal!!',
                        'hora': '14:03'
                    }
                ],
                'ultimo_mensaje': {
                    'text': 'hola que tal!!',
                    'hora': '14:03'
                }
            },
            {
                'usuario': 'Jose',
                'bandera': true,
                'conversacion': [
                    {
                        'user': 'tu',
                        'text': 'hola!!',
                        'hora': '14:00'
                    },
                    {
                        'user': 'Jose',
                        'text': 'Constesta el telefono',
                        'hora': '14:03'
                    }
                ],
                'ultimo_mensaje': {
                    'text': 'Constesta el telefono',
                    'hora': '14:03'
                }
            }
        ];
        this.text = '';
    }
    ChatComponent.prototype.ngOnInit = function () {
    };
    ChatComponent.prototype.minimizarChat = function () {
        this.flagChat = !this.flagChat;
        if (this.tam_chat === 530) {
            this.tam_chat = 200;
        }
        else {
            this.tam_chat = 530;
        }
        console.log(this.tam_chat);
    };
    ChatComponent.prototype.elegirMensaje = function (mensaje) {
        this.chats.splice(0, 0, mensaje);
        this.chats.pop();
    };
    ChatComponent.prototype.onEnter = function (event, value, text) {
        var mensaje = { 'user': 'tu', 'text': '', 'hora': new Date().getHours() };
        if (event.key === 'Enter') {
            mensaje.text = text;
            value.conversacion.push(mensaje);
            this.text = '';
        }
    };
    ChatComponent = __decorate([
        core_1.Component({
            selector: 'app-chat',
            templateUrl: './chat.component.html',
            styleUrls: ['./chat.component.css']
        })
    ], ChatComponent);
    return ChatComponent;
}());
exports.ChatComponent = ChatComponent;
//# sourceMappingURL=chat.component.js.map