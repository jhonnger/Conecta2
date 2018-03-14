import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-chat',
  templateUrl: './chat.component.html',
  styleUrls: ['./chat.component.css']
})
export class ChatComponent implements OnInit {

  flagChat = true;

  constructor() { }

  ngOnInit() {
  }


  minimizarChat() {
    this.flagChat = !this.flagChat;
    console.log(this.flagChat);
  }
}
