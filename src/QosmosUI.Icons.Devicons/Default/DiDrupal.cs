// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Devicons.Default;

public class DiDrupal : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "32";

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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M21.627 8.169c-1.32-0.822-2.564-1.145-3.809-1.967-0.772-0.523-1.843-1.768-2.739-2.838-0.174 1.718-0.697 2.415-1.295 2.913-1.27 0.996-2.067 1.295-3.162 1.892-0.921 0.473-5.926 3.461-5.926 9.885s5.403 11.155 11.404 11.155c6.001 0 11.204-4.357 11.204-10.955s-4.88-9.586-5.677-10.084zM21.771 26.865c-0.125 0.125-1.27 0.921-2.614 1.046s-3.162 0.199-4.258-0.797c-0.174-0.174-0.124-0.423 0-0.523s0.224-0.174 0.373-0.174c0.149 0 0.124 0 0.199 0.050 0.498 0.398 1.245 0.722 2.838 0.722s2.714-0.448 3.212-0.822c0.224-0.174 0.324-0.025 0.349 0.075s0.075 0.249-0.1 0.423zM17.414 24.599c0.274-0.249 0.722-0.647 1.145-0.822s0.647-0.149 1.046-0.149 0.822 0.025 1.12 0.224c0.299 0.199 0.473 0.647 0.573 0.896s0 0.398-0.199 0.498c-0.174 0.1-0.199 0.050-0.374-0.274s-0.324-0.647-1.195-0.647-1.145 0.299-1.569 0.647c-0.423 0.349-0.573 0.473-0.722 0.274s-0.099-0.398 0.175-0.647zM24.012 24.798c-0.896-0.075-2.689-2.863-3.834-2.913-1.444-0.050-4.581 3.013-7.046 3.013-1.494 0-1.942-0.224-2.44-0.548-0.747-0.523-1.12-1.32-1.096-2.415 0.025-1.942 1.842-3.76 4.133-3.785 2.913-0.025 4.93 2.888 6.399 2.863 1.245-0.025 3.635-2.465 4.805-2.465 1.245 0 1.594 1.295 1.594 2.066s-0.249 2.166-0.847 3.038c-0.598 0.872-0.971 1.195-1.668 1.145z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
