import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GClientComponent } from './gclient.component';

describe('GClientComponent', () => {
  let component: GClientComponent;
  let fixture: ComponentFixture<GClientComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GClientComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GClientComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
