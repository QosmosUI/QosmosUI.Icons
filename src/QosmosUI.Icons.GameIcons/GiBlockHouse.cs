// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiBlockHouse : ComponentBase
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
		builder.AddAttribute(14, "d", "M375 32v41H100.326l-49.6 62h410.547l-49.6-62H393V32h-18zM85.727 153L96 163.273 106.273 153H85.727zm64 0L160 163.273 170.273 153h-20.546zm64 0L224 163.273 234.273 153h-20.546zm64 0l11.185 11.186L300.645 153h-22.918zm64 0L352 163.273 362.273 153h-20.546zm64 0L416 163.273 426.273 153h-20.546zM128 156.727L108.727 176 128 195.273 147.273 176 128 156.727zm64 0L172.727 176 192 195.273 211.273 176 192 156.727zm64 0L236.727 176l19.42 19.422 19.736-18.813L256 156.726zm128 0L364.727 176 384 195.273 403.273 176 384 156.727zm-62.623 1.377l-19.732 18.814L320 195.273 339.273 176l-17.896-17.896zM73 165.727v20.546L83.273 176 73 165.727zm366 0L428.727 176 439 186.273v-20.546zm-343 23L85.727 199h20.546L96 188.727zm64 0L149.727 199h20.546L160 188.727zm64 0L213.727 199h20.546L224 188.727zm128 0L341.727 199h20.546L352 188.727zm64 0L405.727 199h20.546L416 188.727zm-127.387.613l-10.13 9.66h19.79l-9.66-9.66zM73 217v126h366V217H73zm23 39h80v32H96v-32zm112 0h96v32h-96v-32zm128 0h80v32h-80v-32zM75.5 361l43.5 58v-30l-21-28H75.5zm61.5 0v126h23v-71h48v71h167V361H137zm277 0l-21 28v30l43.5-58H414zm-174 55h32v32h-32v-32zm64 0h32v32h-32v-32z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
