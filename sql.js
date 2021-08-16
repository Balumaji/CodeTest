const mysql = require("mysql");
const dbSocketPath = process.env.DB_SOCKET_PATH || "/cloudsql";
const pool = mysql.createPool({
    connectionLimit: 10,
    host: "freshwork.cpg73fwbrb4a.ap-south-1.rds.amazonaws.com",
    user: "freshwork",
    password: "8RAfTMpR,7",
    port: "3306",
    database: "freshwork_rds",
});
class Repository {
    async prepareQuery(query, parameters) {
        console.log("----------------------------prepareQuery called-----------------------------");
        return new Promise((resolve, reject) => {
            pool.getConnection(function (err, connection) {
                connection.query(query, parameters, (err, result) => {
                    if (err) {
                        console.log("-------------------- while prepare query errrrrrrrr------------------------------>", err);
                        reject(err);
                    };
                    connection.release();
                    resolve(result);
                });
            });
        });
    }
};
exports.Repository = Repository;