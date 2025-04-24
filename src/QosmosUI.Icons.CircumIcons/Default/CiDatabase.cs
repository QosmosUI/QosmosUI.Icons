// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiDatabase : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "id", "Database");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M12,2.06c-3.53,0-6.18,1.23-6.18,2.86V19.08c0,1.63,2.65,2.86,6.18,2.86s6.18-1.23,6.18-2.86V4.92C18.18,3.29,15.52,2.06,12,2.06Zm5.18,17.02c0,.78-1.97,1.86-5.18,1.86s-5.18-1.08-5.18-1.86V15.96A9.349,9.349,0,0,0,12,17.22a9.373,9.373,0,0,0,5.18-1.26Zm0-4.72c0,.78-1.97,1.86-5.18,1.86s-5.18-1.08-5.18-1.86V11.24A9.349,9.349,0,0,0,12,12.5a9.373,9.373,0,0,0,5.18-1.26Zm0-4.72c0,.78-1.97,1.86-5.18,1.86S6.82,10.42,6.82,9.64V6.52A9.349,9.349,0,0,0,12,7.78a9.373,9.373,0,0,0,5.18-1.26ZM12,6.78c-3.21,0-5.18-1.08-5.18-1.86S8.79,3.06,12,3.06s5.18,1.08,5.18,1.86S15.21,6.78,12,6.78Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
