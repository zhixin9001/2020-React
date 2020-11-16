import React from "react";
import CommentList from "./CommentList1";
import CommentForm from "./CommentForm";
import withTimer from "../c06/withTimer";
import "./CommentBox.css";

const comments = [
  {
    author: "Nate",
    content: "Hello React! This is a sample comment.",
  },
  { author: "Kevin", content: "Hello Redux!" },
  { author: "Bood", content: "Hello Rekit!" },
];

export class CommentBox extends React.PureComponent {
  render() {
    return (
      <div>
        <h1>Comments ({comments.length})</h1>
        <CommentForm />
        <CommentList comments={comments} />
      </div>
    );
  }
}

export default CommentBox;
