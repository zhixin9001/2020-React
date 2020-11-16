import React, { PureComponent } from "react";
import PropTypes from "prop-types";
import CommentItem from "./CommentItem1";
import { render } from "react-dom";

export default class CommentList extends PureComponent {
  // static propTypes = {
  //   comments: PropTypes.number.isRequired
  // };

  render() {
    return(
      <div>
        {this.props.comments.map(comment=>
          <CommentItem comment={comment}/>)}
      </div>
    );
  }
}