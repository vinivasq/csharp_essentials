namespace EditaLabels
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class ContainerExpirationPolicy
    {
        public string? Cadence { get; set; }
        public bool? Enabled { get; set; }
        public int? Keep_n { get; set; }
        public string? Older_than { get; set; }
        public string? Name_regex { get; set; }
        public object? Name_regex_keep { get; set; }
        public DateTime? Next_run_at { get; set; }
    }

    public class Links
    {
        public string? Self { get; set; }
        public string? Issues { get; set; }
        public string? Merge_requests { get; set; }
        public string? Repo_branches { get; set; }
        public string? Labels { get; set; }
        public string? Events { get; set; }
        public string? Members { get; set; }
        public string? Cluster_agents { get; set; }
    }

    public class Namespace
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Path { get; set; }
        public string? Kind { get; set; }
        public string? Full_path { get; set; }
        public int? Parent_id { get; set; }
        public object? Avatar_url { get; set; }
        public string? Web_url { get; set; }
    }

    public class Permissions
    {
        public object? Project_access { get; set; }
        public object? Group_access { get; set; }
    }

    public class ProjectResponse
    {
        public int? Id { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }
        public string? Name_with_namespace { get; set; }
        public string? Path { get; set; }
        public string? Path_with_namespace { get; set; }
        public DateTime? Created_at { get; set; }
        public string? Default_branch { get; set; }
        public List<object>? Tag_list { get; set; }
        public List<object>? Topics { get; set; }
        public string? Ssh_url_to_repo { get; set; }
        public string? Http_url_to_repo { get; set; }
        public string? Web_url { get; set; }
        public string? Readme_url { get; set; }
        public int? Forks_count { get; set; }
        public object? Avatar_url { get; set; }
        public int? Star_count { get; set; }
        public DateTime? Last_activity_at { get; set; }
        public Namespace? @Namespace { get; set; }
        public Links? Links { get; set; }
        public bool? Packages_enabled { get; set; }
        public bool? Empty_repo { get; set; }
        public bool? Archived { get; set; }
        public string? Visibility { get; set; }
        public bool? Resolve_outdated_diff_discussions { get; set; }
        public ContainerExpirationPolicy? Container_expiration_policy { get; set; }
        public bool? Issues_enabled { get; set; }
        public bool? Merge_requests_enabled { get; set; }
        public bool? Wiki_enabled { get; set; }
        public bool? Jobs_enabled { get; set; }
        public bool? Snippets_enabled { get; set; }
        public bool? Container_registry_enabled { get; set; }
        public bool? Service_desk_enabled { get; set; }
        public object? Service_desk_address { get; set; }
        public bool? Can_create_merge_request_in { get; set; }
        public string? Issues_access_level { get; set; }
        public string? Repository_access_level { get; set; }
        public string? Merge_requests_access_level { get; set; }
        public string? Forking_access_level { get; set; }
        public string? Wiki_access_level { get; set; }
        public string? Builds_access_level { get; set; }
        public string? Snippets_access_level { get; set; }
        public string? Pages_access_level { get; set; }
        public string? Analytics_access_level { get; set; }
        public string? Container_registry_access_level { get; set; }
        public string? Security_and_compliance_access_level { get; set; }
        public string? Releases_access_level { get; set; }
        public string? Environments_access_level { get; set; }
        public string? Feature_flags_access_level { get; set; }
        public string? Infrastructure_access_level { get; set; }
        public string? Monitor_access_level { get; set; }
        public bool? Emails_disabled { get; set; }
        public bool? Emails_enabled { get; set; }
        public bool? Shared_runners_enabled { get; set; }
        public bool? Lfs_enabled { get; set; }
        public int? Creator_id { get; set; }
        public object? Import_url { get; set; }
        public string? Import_type { get; set; }
        public string? Import_status { get; set; }
        public int? Open_issues_count { get; set; }
        public string? Description_html { get; set; }
        public DateTime? Updated_at { get; set; }
        public int? Ci_default_git_depth { get; set; }
        public bool? Ci_forward_deployment_enabled { get; set; }
        public bool? Ci_forward_deployment_rollback_allowed { get; set; }
        public bool? Ci_job_token_scope_enabled { get; set; }
        public bool? Ci_separated_caches { get; set; }
        public bool? Ci_allow_fork_pipelines_to_run_in_parent_project { get; set; }
        public string? Build_git_strategy { get; set; }
        public bool? Keep_latest_artifact { get; set; }
        public bool? Restrict_user_defined_variables { get; set; }
        public string? Runners_token { get; set; }
        public object? Runner_token_expiration_interval { get; set; }
        public bool? Group_runners_enabled { get; set; }
        public string? Auto_cancel_pending_pipelines { get; set; }
        public int? Build_timeout { get; set; }
        public bool? Auto_devops_enabled { get; set; }
        public string? Auto_devops_deploy_strategy { get; set; }
        public string? Ci_config_path { get; set; }
        public bool? Public_jobs { get; set; }
        public List<object>? Shared_with_groups { get; set; }
        public bool? Only_allow_merge_if_pipeline_succeeds { get; set; }
        public object? Allow_merge_on_skipped_pipeline { get; set; }
        public bool? Request_access_enabled { get; set; }
        public bool? Only_allow_merge_if_all_discussions_are_resolved { get; set; }
        public object? Remove_source_branch_after_merge { get; set; }
        public bool? Printing_merge_request_link_enabled { get; set; }
        public string? Merge_method { get; set; }
        public string? Squash_option { get; set; }
        public bool? Enforce_auth_checks_on_uploads { get; set; }
        public object? Suggestion_commit_message { get; set; }
        public object? Merge_commit_template { get; set; }
        public object? Squash_commit_template { get; set; }
        public object? Issue_branch_template { get; set; }
        public bool? Autoclose_referenced_issues { get; set; }
        public string? Repository_storage { get; set; }
        public int? Approvals_before_merge { get; set; }
        public bool? Mirror { get; set; }
        public object? External_authorization_classification_label { get; set; }
        public object? Marked_for_deletion_at { get; set; }
        public object? Marked_for_deletion_on { get; set; }
        public bool? Requirements_enabled { get; set; }
        public string? Requirements_access_level { get; set; }
        public bool? Security_and_compliance_enabled { get; set; }
        public List<object>? Compliance_frameworks { get; set; }
        public object? Issues_template { get; set; }
        public object? Merge_requests_template { get; set; }
        public bool? Merge_pipelines_enabled { get; set; }
        public bool? Merge_trains_enabled { get; set; }
        public bool? Allow_pipeline_trigger_approve_deployment { get; set; }
        public Permissions? Permissions { get; set; }
    }
}
