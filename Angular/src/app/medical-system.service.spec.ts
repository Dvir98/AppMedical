import { TestBed } from '@angular/core/testing';

import { MedicalSystemService } from './medical-system.service';

describe('MedicalSystemService', () => {
  let service: MedicalSystemService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MedicalSystemService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
