import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { DashboardComponent } from './dashboard.component';
import { EquipmentComponent } from './Equipment/equipment.component';
import { EditComponent } from './Equipment/edit.component';
import { AdminComponent } from "./admin/admin.component";
import { EditModuleComponent } from "./Admin/edit-module/edit-module.component";

const routes: Routes = [
    { path: '', redirectTo: '/dashboard', pathMatch: 'full' },
    { path: 'dashboard', component: DashboardComponent },
    { path: 'Equipment', component: EquipmentComponent },
    { path: 'Admin', component: AdminComponent },
    { path: 'EditModule/:module', component: EditModuleComponent },
    { path: 'edit/:module/:id', component: EditComponent }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }
