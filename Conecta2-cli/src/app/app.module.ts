import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { MatTabsModule } from '@angular/material/tabs';
import { MatCardModule } from '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { HomeComponent } from './components/home/home.component';
import { MonitoreoComponent } from './components/home/monitoreo/monitoreo.component';
import { AgmCoreModule } from '@agm/core';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    MonitoreoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatTabsModule,
    MatCardModule,
    MatIconModule,
    MatButtonModule,
    AgmCoreModule.forRoot({
      apiKey: 'AIzaSyD6l0Wq6cXBaDqF7I03FxvG-6-Py0Ib0F4',
      libraries: ['places']
    }),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
