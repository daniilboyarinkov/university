import React from 'react';
import {SEARCH_FIELDS, TSearchField} from '../constants/search';

type IProps = {
    searchRequest: string;
    setSearchRequest: (value: ((prevState: string) => string) | string) => void,
    searchField: string;
    setSearchField: (value: ((prevState: TSearchField) => TSearchField) | TSearchField) => void,
}

const Search = (props: IProps) => {
    return (
        <div className="form-control">
            <div className="input-group">
                <input
                    type="text"
                    placeholder="Search…"
                    className="input input-bordered"
                    value={props.searchRequest}
                    onChange={(e) => props.setSearchRequest(e.target.value)}
                />
                <button className="btn btn-square">
                    <svg xmlns="http://www.w3.org/2000/svg"
                         className="h-6 w-6" fill="none"
                         viewBox="0 0 24 24"
                         stroke="currentColor">
                        <path strokeLinecap="round"
                              strokeLinejoin="round"
                              strokeWidth="2"
                              d="M21 21l-6-6m2-5a7 7 0 11-14 0 7 7 0 0114 0z"/>
                    </svg>
                </button>
                <div className="tooltip tooltip-left" data-tip="Search by">
                    <select className="select select-bordered"
                            value={props.searchField}
                            onChange={(e) => props.setSearchField(e.target.value as TSearchField)}>
                        {SEARCH_FIELDS.map((f, i) => <option key={f}>{f}</option>)}
                    </select>
                </div>
            </div>
        </div>
    );
};

export default Search;
