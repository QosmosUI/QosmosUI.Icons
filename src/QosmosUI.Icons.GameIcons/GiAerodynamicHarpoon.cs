// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiAerodynamicHarpoon : ComponentBase
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
		builder.AddAttribute(14, "d", "M18.285 16.297v20.52L127.088 163.57c35.955 91.222 6.358 156.645-59.43 178.098l111.852 34.758c6.88-3.465 12.225-7.756 17.69-12.64 38.677-34.554 39.72-103.556-23.38-190.208 98.413 71.66 174.565 60.578 202.85 5.686L342.545 66.78c-21.29 65.28-86.246 95.3-176.545 60.794L36.908 16.297H18.285zM401.998 221.48c-18.06 55.37-84.184 71.942-172.205 7.846 64.098 88.022 47.94 153.736-7.432 171.79l73.095 22.714c4.504-2.256 8.003-5.05 11.566-8.252l-.002-.006c25.274-22.58 25.955-67.676-15.28-124.302 64.31 46.833 114.076 39.59 132.56 3.716L402 221.48zm41.68 114.366c-10.75 32.968-50 42.71-102.408 4.545 38.163 52.41 28.42 91.66-4.55 102.41l153.8 46.843-46.84-153.797h-.002z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
