import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {AppSettings} from '../endPoint.config';

@Injectable()
export class TipoDenunciaService {

  url = AppSettings.API_ENDPOINT + '/TipoDenuncia';

  constructor(private http: HttpClient
              ) { }

  leer(id) {
    return this.http.get(this.url + '/' + id)
      .map( res => {
        return res;
      });
  }
  listar() {
    return this.http.get(this.url + '/' )
      .map( res => {
        return res;
      });
  }
}
