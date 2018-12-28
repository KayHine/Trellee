import React, { Component } from 'react';

export class Trellee extends Component {
  static displayName = Trellee.name;

  constructor(props) {
    super(props);
    this.state = {
      cards: [],
      loading: true
    };

    fetch('api/Trellee/ToDoCards')
      .then(response => console.log(response))
      .catch(err => console.log(err));
  }

  static renderCardsTable(cards) {
    return (
      <table className='table table-striped'>
        <thead>
          <tr>
            <th>Cards</th>
          </tr>
        </thead>
        <tbody>
          {cards.map(card => 
            <td>{card.title}</td>  
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : Trellee.renderCardsTable(this.state.cards);

    return (
      <div>
        <h1>Welcome to Trellee!</h1>
        {contents}
      </div>
    );
  }
}