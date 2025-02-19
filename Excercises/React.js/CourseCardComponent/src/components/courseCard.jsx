import React, { Component } from "react";

class CourseCard extends Component {
  state = {
    items: this.props.category.map((item, key) => {
      return (
        <li id={key}>
          <a>{item}</a>
        </li>
      );
    }),
  };

  render() {
    return (
      <li className="post" data-category={this.props.category.join(' ')}>
        <article>
          <figure>
            <a href={this.props.link} target="_blank">
              <img src={this.props.image} alt="" />
            </a>
            <figcaption>
              <ol className="post-categories">{this.state.items}</ol>
              <h2 className="post-title">
                <a href={this.props.link} target="_blank">
                  {this.props.title}
                </a>
              </h2>
            </figcaption>
          </figure>
        </article>
      </li>
    );
  }
}

export default CourseCard;