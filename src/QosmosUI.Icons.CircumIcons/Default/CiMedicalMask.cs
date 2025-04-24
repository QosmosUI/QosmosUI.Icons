// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiMedicalMask : ComponentBase
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
		builder.AddAttribute(14, "id", "Medical_Mask");
		builder.AddAttribute(15, "data-name", "Medical Mask");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M21.435,12.53H19.5V9.17h1.94a.5.5,0,0,0,.5-.5.5.5,0,0,0-.5-.5H19.5V7.23A2.5,2.5,0,0,0,17,4.73H7a2.507,2.507,0,0,0-2.5,2.5v.94H2.565a.5.5,0,0,0-.5.5.5.5,0,0,0,.5.5H4.5v3.36H2.565a.5.5,0,0,0-.5.5.5.5,0,0,0,.5.5H4.5v.33a4.283,4.283,0,0,0,2.43,3.84l1.74.82a7.79,7.79,0,0,0,6.67,0l1.73-.82h.01a4.274,4.274,0,0,0,2.42-3.84v-.33h1.94a.5.5,0,0,0,.5-.5A.5.5,0,0,0,21.435,12.53ZM18.5,13.86a3.238,3.238,0,0,1-1.85,2.93l-1.73.82a6.767,6.767,0,0,1-5.83,0l-1.73-.82A3.248,3.248,0,0,1,5.5,13.86V7.23A1.5,1.5,0,0,1,7,5.73H17a1.5,1.5,0,0,1,1.5,1.5Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M14.5,14.534h-5a.5.5,0,0,1,0-1h5a.5.5,0,0,1,0,1Z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M16,10.168H8a.5.5,0,1,1,0-1h8a.5.5,0,0,1,0,1Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
