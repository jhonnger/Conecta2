import { TestBed, inject } from '@angular/core/testing';

import { TipoDenunciaService } from './tipo-denuncia.service';

describe('TipoDenunciaService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [TipoDenunciaService]
    });
  });

  it('should be created', inject([TipoDenunciaService], (service: TipoDenunciaService) => {
    expect(service).toBeTruthy();
  }));
});
