const os = require("os");
// Showing OS informations
console.log("------------------------");
console.log(`CPU Architecture: ${os.arch()}`);
console.log(`OS Platform: ${os.platform}`);
console.log(`Total Memory: ${Math.round(os.totalmem() / Math.pow(1024, 3))}GB`);
console.log(`Free Memory: ${Math.round(os.freemem() / Math.pow(1024, 3))}GB`);
console.log(`Machine Type: ${os.machine()}`);
console.log("------------------------");
console.log(`CPU Cores:`);
// Itereating CPU cores
os.cpus().forEach((core) => {
  console.log(core);
});
