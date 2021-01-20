import { Component, OnInit, Input } from '@angular/core';
@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})
export class TableComponent implements OnInit {
  @Input() dataSource: any;
  displayedColumns: string[] = ['medicalID', 'platelets', 'albumin', 'date'];
  constructor() { }

  ngOnInit(): void {
  }

}
