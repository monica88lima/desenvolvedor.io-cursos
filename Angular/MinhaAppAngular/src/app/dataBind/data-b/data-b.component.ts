import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-data-b',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './data-b.component.html',
  styleUrl: './data-b.component.scss'
})
export class DataBComponent {
contador: number = 100;
nome: string = '';

url: string = 'data:image/png;base64,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';
adicionarClique() {
  this.contador++;
}
zerarContador() {
  this.contador = 0;
}

keyUp(event: any) {
    this.nome = event.target.value;
}
}
