import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { MonitoreoComponent } from './components/home/monitoreo/monitoreo.component';

const routes: Routes = [
  {
    path: '', component: HomeComponent,
    children: [ // rutas hijas, se verán dentro del componente padre
      { path: 'monitoreo', component: MonitoreoComponent },
      { path: '**', pathMatch: 'full', redirectTo: 'home' },
    ]
  },
  { path: '**', pathMatch: 'full', redirectTo: '' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
