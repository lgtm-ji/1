module DD_tb();

	reg [15:0] x0;
	reg [15:0] x1;
	reg [15:0] x2;
	reg [15:0] x3;
	reg [15:0] y0;
	reg [15:0] y1;
	reg [15:0] y2;
	reg [15:0] y3;
	reg [15:0] r0;
	reg [15:0] r1;
	reg [15:0] r2;
	reg [15:0] r3;
	wire wrong;
	wire [15:0] x_out;
	wire [15:0] y_out;
	reg clk;
	wire wrong_adder1;
	wire wrong_adder2;

	//----Code starts here: integrated by Robei-----
	initial
	begin
	//reset<=1;
	clk<=0;
	#5 
	//reset<=0;
	#220 
	$finish;
	end
	always
	begin 
	#5 
	clk=~clk;
	end
	
	initial
	begin
	x0<=0;
	y0<=0;
	x1<=2000;
	y1<=0;
	x2<=0;
	y2<=2000;
	x3<=2000;
	y3<=2000;
	end
	
	reg  [15:0]    data_mem_1[0:19];
	reg  [15:0]    data_mem_2[0:19];
	reg  [15:0]    data_mem_3[0:19];
	reg  [15:0]    data_mem_4[0:19];
	integer     k_1,k_2,k_3,k_4;
	
	initial
	begin
	$readmemh("C:\\Users\\xyls\\Desktop\\uwb\\tb\\top_r1.dat",data_mem_1,0);
	$readmemh("C:\\Users\\xyls\\Desktop\\uwb\\tb\\top_r2.dat",data_mem_2,0);
	$readmemh("C:\\Users\\xyls\\Desktop\\uwb\\tb\\top_r3.dat",data_mem_3,0);
	$readmemh("C:\\Users\\xyls\\Desktop\\uwb\\tb\\top_r4.dat",data_mem_4,0);
	end
	always @(posedge clk) begin
	for(k_1=0; k_1<19; k_1=k_1+1)  begin
	#10
	r0 <= data_mem_1[k_1] ;
	end
	end  
	 always @(posedge clk) begin          
	for(k_2=0; k_2<19; k_2=k_2+1)  begin
	#10     
	r1  <= data_mem_2[k_2] ;      
	end
	end
	always @(posedge clk) begin
	for(k_3=0; k_3<19; k_3=k_3+1)  begin
	#10
	r2 <= data_mem_3[k_3] ;          
	end
	end
	always @(posedge clk) begin
	for(k_4=0; k_4<19; k_4=k_4+1)  begin
	#10
	r3 <= data_mem_4[k_4] ;          
	end
	end
	always @(x_out, y_out)
	begin
	$display("x_out= %d" , x_out);
	$display("y_out= %d" , y_out);
	end
	initial begin
		$dumpfile ("D:/robeicomp/robei_out/mycorcode/2d_model_test/DD_tb.vcd");
		$dumpvars;
	end
	//---Module instantiation---
	top_2D top_2D1(
		.x0(x0),
		.x1(x1),
		.x2(x2),
		.x3(x3),
		.y0(y0),
		.y1(y1),
		.y2(y2),
		.y3(y3),
		.r0(r0),
		.r1(r1),
		.r2(r2),
		.r3(r3),
		.wrong(wrong),
		.x_out(x_out),
		.y_out(y_out),
		.clk(clk),
		.wrong_adder1(wrong_adder1),
		.wrong_adder2(wrong_adder2));

endmodule    //DD_tb

