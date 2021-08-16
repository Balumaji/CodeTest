const mysql = require("mysql");
const dbSocketPath = process.env.DB_SOCKET_PATH || "/cloudsql";
const pool = mysql.createPool({
    connectionLimit: 10,
    host: process.env.DB_HOST,
    user: process.env.DB_USER,
    password: process.env.DB_PASS,
    port: process.env.DB_PORT,
    database: process.env.DB_NAME,
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