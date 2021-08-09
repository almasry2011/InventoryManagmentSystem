
import { Component, OnInit } from '@angular/core';
import { DashboardModel } from '../../models/DashboardModel';
import { DashboardService } from '../../services/dashboard.service';

@Component({
  selector: 'app-dashboard-top-cards',
  templateUrl: './dashboard-top-cards.component.html',
  styleUrls: ['./dashboard-top-cards.component.css']
})
export class DashboardTopCardsComponent implements OnInit {

  constructor(private dashboardSvc: DashboardService) { }
  dashboardModel: DashboardModel | undefined;

  ngOnInit(): void {

    this.dashboardSvc.GetDashboardData().subscribe(data => {
      this.dashboardModel = data;
      console.log(this.dashboardModel)



      // $('.counter-value').each(function () {
      //   $(this).prop('Counter', 0).animate({
      //     Counter: $(this).text()
      //   }, {
      //     duration: 3500,
      //     easing: 'swing',
      //     step: function (now) {
      //       $(this).text(Math.ceil(now));
      //     }
      //   });
      // });



    })



  }

}
