import { Component, OnInit } from '@angular/core';
import {FormBuilder, FormControl, FormGroup, Validators} from '@angular/forms';

@Component({
  selector: 'app-nuevocaso',
  templateUrl: './nuevocaso.component.html',
  styleUrls: ['./nuevocaso.component.css']
})
export class NuevocasoComponent implements OnInit {

  firstFormGroup: FormGroup;
  secondFormGroup: FormGroup;
  date = new FormControl(new Date());

  constructor(private _formBuilder: FormBuilder) { }

  ngOnInit() {
    this.firstFormGroup = this._formBuilder.group({
      tipoIncidente: ['', Validators.required],
      horaIncidente: ['', Validators.required]
    });
    this.secondFormGroup = this._formBuilder.group({
      secondCtrl: ['', Validators.required]
    });

    const horaActual = this.obtenerHoraActual();
    const fechaActual = this.obtenerFechaActual();

    this.firstFormGroup.patchValue({
      horaIncidente: horaActual
    });
  }

  obtenerHoraActual() {
    const currentdate = new Date();
    const time = currentdate.getHours() + ':' + currentdate.getMinutes();
    return time;
  }
  obtenerFechaActual() {
    const currentdate = new Date();
    const date = (currentdate.getMonth() + 1)  + '/'
      + currentdate.getDate() + '/'
      + currentdate.getFullYear();
    return date;
  }

}
