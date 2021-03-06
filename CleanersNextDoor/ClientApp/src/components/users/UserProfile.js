﻿import React, { Component } from 'react';
import { Authentication } from '../../services/authentication'

export class UserProfile extends Component {
    constructor(props) {
        super(props)
        this.state = {
            user: null,
            loading: true
        }
    }

    componentDidMount() {
        this.populateProfileInformation()
    }
    static renderProfile(user) {
        return (
            <div>
                {user.username}
            </div>
            )
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : UserProfile.renderProfile(this.state.user);
        return (
            <div className="container">
                Profile
                {contents}
            </div>
            )
    }

    async populateProfileInformation() {
        const claimId = await Authentication.getClaimId()
        const response = await fetch(`users/${claimId}`);
        const data = await response.json();
        this.setState({ user: data, loading: false });
    }
}