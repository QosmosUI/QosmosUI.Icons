// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiCalendar : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M119 31v66h18V31h-18zm256 0v66h18V31h-18zM73 89v30h366V89h-28v26h-54V89H155v26h-54V89H73zm0 48v302h366V137H73zm110 14h18v32h46v-32h18v32h46v-32h18v32h46v-32h18v32h32v18h-32v46h32v18h-32v46h32v18h-32v46h32v18H265v32h-18v-32h-46v32h-18v-32h-46v32h-18v-32H87v-18h32v-46H87v-18h32v-46H87v-18h32v-46H87v-18h96v-32zm-46 50v46h46v-46h-46zm64 0v46h46v-46h-46zm64 0v46h46v-46h-46zm64 0v46h46v-46h-46zm-192 64v46h46v-46h-46zm64 0v46h46v-46h-46zm64 0v13.27c2.545-5.936 7.334-10.725 13.27-13.27H265zm32.73 0c5.936 2.545 10.725 7.334 13.27 13.27V265h-13.27zm31.27 0v46h46v-46h-46zm-41 16c-3.973 0-7 3.027-7 7s3.027 7 7 7 7-3.027 7-7-3.027-7-7-7zm-23 16.73V311h13.27c-5.936-2.545-10.725-7.334-13.27-13.27zm46 0c-2.545 5.936-7.334 10.725-13.27 13.27H311v-13.27zM137 329v46h46v-46h-46zm64 0v46h46v-46h-46zm64 0v46h46v-46h-46zm64 0v46h46v-46h-46z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
