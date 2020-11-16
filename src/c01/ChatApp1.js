import React from 'react';

class MessageList extends React.PureComponent { // todo purecomponent
    render() {
        return <ul>{this.props.messages.map(msg => <li>{msg}</li>)}</ul>
    }
}

export default class ChatApp extends React.Component {
    state = {
        messages: [],
        inputMsg: ""
    }

    handleChange = evt => {
        this.setState({
            inputMsg: evt.target.value
        });
    }

    handleSend = () => {
        const text = this.state.inputMsg;
        if (text) {
            const newMessages = [...this.state.messages, text];
            this.setState({
                messages: newMessages,
                inputMsg: ""
            })
        }
    }

    render() {
        return (
            <div>
                <MessageList messages={this.state.messages}></MessageList>
                <div>
                    <input value={this.state.inputMsg} onChange={this.handleChange}></input>
                    <button onClick={this.handleSend}>Send</button>
                </div>
            </div>
        );
    }
}