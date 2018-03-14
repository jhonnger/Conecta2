import {Component, OnInit, ViewChild} from '@angular/core';
import {AgmMap} from '@agm/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  @ViewChild('mapMonitoreo') mapMonitoreo: AgmMap;
  @ViewChild('mapUnidades') mapUnidades: AgmMap;

  lat = 40.7786232;
  lng = -74.0007019;
  constructor() { }

  ngOnInit() {
   // algo.triggerResize(true);
  }
  cambio(event) {
    switch (event.index) {
      case 0:
        this.mapMonitoreo.triggerResize(true);
        break;
      case 1:
        this.mapUnidades.triggerResize(true);
        break;
    }
  }

}
