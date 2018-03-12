import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-monitoreo',
  templateUrl: './monitoreo.component.html',
  styleUrls: ['./monitoreo.component.css']
})
export class MonitoreoComponent implements OnInit {

  title: string = 'My first AGM project';
  lat: number = 40.7786232;
  lng: number = -74.0007019;
  constructor() { }

  ngOnInit() {
  }

}
