import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CancInstPaliFormComponent } from './canc-inst-pali-form.component';

describe('CancInstPaliFormComponent', () => {
  let component: CancInstPaliFormComponent;
  let fixture: ComponentFixture<CancInstPaliFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CancInstPaliFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CancInstPaliFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
