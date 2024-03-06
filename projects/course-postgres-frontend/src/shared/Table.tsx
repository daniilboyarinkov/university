import React, {useState} from "react";

import {TABLE_ROW_LIMIT, TABLE_HEADER_TITLES} from "../constants/table";

type TableProps<T> = {
    data: Array<T>;
    headers?: IHeadRowTitle[];
    rowLimit?: number;
    hideOverLimit?: boolean;
};

export function Table<T extends object>({
                                            data = [],
                                            headers = TABLE_HEADER_TITLES,
                                            rowLimit = TABLE_ROW_LIMIT,
                                            hideOverLimit = true,
                                        }: TableProps<T>) {
    const [expanded, setExpanded] = useState(!hideOverLimit);

    const handleExpandedChange = () => setExpanded((prev) => !prev);

    return (
        <div className="grid place-items-center overflow-x-auto">
            {data.length > 0 ?
                <>
                    <table className="table-zebra table-compact table w-full">
                        <TableHeadRow headers={headers ?? []}/>
                        <tbody>
                        {data.map((item, index) =>
                            hideOverLimit && !expanded && index >= rowLimit ? null : (
                                <TableRow key={index} content={item} index={index + 1}/>
                            )
                        )}
                        </tbody>
                    </table>
                    <button className="btn my-2" onClick={handleExpandedChange}>
                        {expanded ? "Hide" : "Show more"}
                    </button>
                </>
                : <div>No data...</div>}
        </div>
    );
}

export interface IHeadRowTitle {
    id: string;
    title: string;
}

type HeadRowProps = {
    headers: IHeadRowTitle[];
};

export const TableHeadRow = ({headers}: HeadRowProps) => {
    return (
        <thead>
        <tr>
            {headers.map((header, index) => (
                <th key={`${header.title}-${index}`}
                    className="whitespace-normal capitalize break-all"
                >{header.title}</th>
            ))}
        </tr>
        </thead>
    );
};

// export interface ITableContent<T> {
//     [ceil: T]: string;
// }

type TableRowProps<T> = {
    content: T;
    // номер строки
    index: number;
};

export function TableRow<T extends object>({
                                               content,
                                               index,
                                           }: TableRowProps<T>) {
    return (
        <tr>
            {/*<th>{index}</th>*/}
            {Object.keys(content).map((el, index) => (
                <td key={`${el}-${index}`} className="whitespace-normal">
                    {String(content[el as keyof typeof content])}
                </td>
            ))}
        </tr>
    );
}
