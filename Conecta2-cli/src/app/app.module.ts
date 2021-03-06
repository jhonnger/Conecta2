import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppRoutingModule } from './app-routing.module';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { MatTabsModule } from '@angular/material/tabs';
import { MatCardModule } from '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatButtonModule } from '@angular/material/button';
import { HomeComponent } from './components/home/home.component';
import { MonitoreoComponent } from './components/home/monitoreo/monitoreo.component';
import { AgmCoreModule } from '@agm/core';
import { ChatComponent } from './components/chat/chat.component';
import { NuevocasoComponent } from './components/nuevocaso/nuevocaso.component';
import {MatDialogModule, MatNativeDateModule} from '@angular/material';
import {MatStepperModule} from '@angular/material/stepper';
import { CommonModule } from '@angular/common';
import { ChatService } from './services/chat.service';
import {MatInputModule} from '@angular/material/input';
import {MatSelectModule} from '@angular/material/select';
import { AmazingTimePickerModule } from 'amazing-time-picker';
import {MatDatepickerModule} from '@angular/material/datepicker';
import { Http } from '@angular/http';
import { HttpClientModule } from '@angular/common/http';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import {TipoDenunciaService} from './services/tipo-denuncia.service';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    MonitoreoComponent,
    ChatComponent,
    NuevocasoComponent
  ], entryComponents: [NuevocasoComponent],
  imports: [
    BrowserModule,
    FormsModule ,
    AppRoutingModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    MatInputModule,
    MatTabsModule,
    MatCardModule,
    MatIconModule,
    MatButtonModule,
    MatDialogModule,
    MatStepperModule,
    MatGridListModule,
    MatListModule,
    CommonModule,
    MatSelectModule,
    AmazingTimePickerModule,
    MatDatepickerModule,
    MatNativeDateModule,
    HttpModule,
    AgmCoreModule.forRoot({
      apiKey: 'AIzaSyD6l0Wq6cXBaDqF7I03FxvG-6-Py0Ib0F4',
      libraries: ['places']
    }),
  ],
  providers: [
    ChatService,
    TipoDenunciaService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
