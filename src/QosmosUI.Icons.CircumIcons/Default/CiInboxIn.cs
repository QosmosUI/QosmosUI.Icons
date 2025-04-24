// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiInboxIn : ComponentBase
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
		builder.AddAttribute(14, "id", "Inbox_In");
		builder.AddAttribute(15, "data-name", "Inbox In");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M11.5,9.361V4.531a.5.5,0,0,1,1,0v4.82l1.27-1.27a.524.524,0,0,1,.71,0,.513.513,0,0,1,0,.71l-2.13,2.12a.492.492,0,0,1-.7,0l-2.12-2.12a.5.5,0,0,1,0-.71.511.511,0,0,1,.7,0Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M20.488,19.949H3.512A1.451,1.451,0,0,1,2.062,18.5V12.861a1.451,1.451,0,0,1,1.45-1.449h4.1a1.444,1.444,0,0,1,1.3.8l1.373,2.726a.449.449,0,0,0,.4.247h2.629a.448.448,0,0,0,.4-.248l1.373-2.724a1.442,1.442,0,0,1,1.3-.8h4.1a1.451,1.451,0,0,1,1.45,1.449V18.5A1.451,1.451,0,0,1,20.488,19.949ZM3.512,12.412a.45.45,0,0,0-.45.449V18.5a.45.45,0,0,0,.45.449H20.488a.45.45,0,0,0,.45-.449V12.861a.45.45,0,0,0-.45-.449h-4.1a.449.449,0,0,0-.4.247L14.61,15.384a1.445,1.445,0,0,1-1.295.8H10.686a1.442,1.442,0,0,1-1.295-.8L8.018,12.659a.449.449,0,0,0-.4-.247Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
