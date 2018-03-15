import { Component, OnInit } from '@angular/core';
import { NgStyle, NgForOf } from '@angular/common';
import { ChatService } from '../../services/chat.service';

@Component({
  selector: 'app-chat',
  templateUrl: './chat.component.html',
  styleUrls: ['./chat.component.css']
})
export class ChatComponent implements OnInit {


  // tslint:disable-next-line:no-inferrable-types
  tam_chat: number = 500;
  // tslint:disable-next-line:no-inferrable-types
  flagChat: boolean = true;

  contactos: any = [];

  contacto: any = {
    'name': 'juan'
  };

  constructor(private chatService: ChatService) { }

  ngOnInit() {

  }


  minimizarChat() {
    this.flagChat = !this.flagChat;
    if (this.tam_chat === 500) {
      this.tam_chat = 200;
    } else {
      this.tam_chat = 500;
    }
    console.log(this.tam_chat);
  }
}
