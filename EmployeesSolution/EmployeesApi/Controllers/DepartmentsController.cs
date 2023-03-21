namespace EmployeesApi.Controllers
{
    public class DepartmentsController : ControllerBase
    {
        private readonly DepartmentsLookup _departmentsLookup;

        public DepartmentsController(DepartmentsLookup departmentsLookup)
        {
            _departmentsLookup = departmentsLookup;
        }

        [HttpGet("/departments")]
        public async Task<ActionResult> GetAllDepartments()
        {
            //var service = new DepartmentItem("id","descip"); //not allowed to call "new" services!!

            var data = await _departmentsLookup.GetDepartmentsAsync();
            var response = new SharedCollectionResponse<DepartmentItem>() { Data = data };
            return Ok(response);
        }
    }
}
