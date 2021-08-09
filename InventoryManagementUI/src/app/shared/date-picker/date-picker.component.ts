import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-date-picker',
  templateUrl: './date-picker.component.html',
  styleUrls: ['./date-picker.component.css']
})
export class DatePickerComponent implements OnInit {
  @Input() range: boolean = false;
  @Output() dateChangeEvent: EventEmitter<any> = new EventEmitter<any>();

  constructor() { }
  dateFormat = 'dd/MMMM/yyyy';
  ngOnInit(): void {
  }
  dateChangeevent(event: any) {
    console.log(event)
    this.dateChangeEvent.next(event)
  }

}
