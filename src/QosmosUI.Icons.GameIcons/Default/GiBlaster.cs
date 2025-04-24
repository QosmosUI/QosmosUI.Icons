// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiBlaster : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 136c60 75-45 45-165 45 51.292 17.097 90.22 30.17 118.125 41.25C164.385 236.653 103.75 249.25 16 256c87.75 6.75 148.386 19.347 193.125 33.75C181.22 300.83 142.293 313.903 91 331c120 0 225-30 165 45 19.66-9.83 42.34-19.584 64.218-30.468C345.538 362.998 364.79 376 399.906 376c48 0 96.093-48 96.093-120s-48.096-120-96.094-120c-35.35 0-54.58 12.824-80.157 30.468-21.765-10.81-44.206-20.695-63.75-30.468zm132.188 47.813c33.136 0 60 32.422 60 72.187s-26.864 72.188-60 72.188c-9.062 0-17.61-2.715-25.313-7.032C388.008 303.676 406 282.742 406 256c0-26.743-17.992-47.68-43.125-65.158 7.702-4.316 16.25-7.032 25.313-7.032z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
