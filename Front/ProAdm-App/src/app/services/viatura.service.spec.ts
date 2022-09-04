/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { ViaturaService } from './viatura.service';

describe('Service: Viatura', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ViaturaService]
    });
  });

  it('should ...', inject([ViaturaService], (service: ViaturaService) => {
    expect(service).toBeTruthy();
  }));
});
