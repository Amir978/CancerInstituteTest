import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CancInstApiComponent } from './canc-inst-api.component';

describe('CancInstApiComponent', () => {
  let component: CancInstApiComponent;
  let fixture: ComponentFixture<CancInstApiComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CancInstApiComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CancInstApiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
