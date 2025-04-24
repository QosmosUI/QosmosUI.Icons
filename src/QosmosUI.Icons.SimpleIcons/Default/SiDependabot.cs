// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiDependabot : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M10.949.3136a1.918 1.918 0 012.102 0l9.3334 6.1182c.541.354.866.957.866 1.604v7.9283c0 .647-.326 1.25-.866 1.604l-9.3334 6.1183a1.918 1.918 0 01-2.102 0l-9.3334-6.1182a1.916 1.916 0 01-.866-1.604V8.0358c0-.647.326-1.25.866-1.604zm1.801 7.1862v.75H6.7498a.75.75 0 00-.75.7501V12h-.5a.25.25 0 00-.25.25v2.5c0 .1381.112.2501.25.2501h.5v1.5c0 .415.336.75.75.75h10.5004a.75.75 0 00.75-.75v-1.5h.5a.25.25 0 00.25-.25v-2.5a.25.25 0 00-.25-.2501h-.5V8.9999a.75.75 0 00-.75-.75H13.5V5.4998a.25.25 0 00-.25-.25H11.5a.25.25 0 00-.25.25v1.75c0 .138.112.25.25.25zm3.2861 5.0892l-1.572 1.572a.303.303 0 01-.428 0l-.947-.947a.303.303 0 010-.428l.322-.322a.303.303 0 01.428 0l.41.411 1.037-1.036a.303.303 0 01.428 0l.322.322a.303.303 0 010 .428zM9.464 14.16v.001a.303.303 0 01-.428 0l-.948-.947a.302.302 0 010-.428l.323-.322a.303.303 0 01.427 0l.412.411 1.036-1.037a.303.303 0 01.427 0l.323.322a.303.303 0 010 .428z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
